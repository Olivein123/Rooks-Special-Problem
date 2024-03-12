import React, { useEffect, useState } from 'react';
import { Pie } from 'react-chartjs-2';
import axios from 'axios';
import 'chart.js/auto';

const PieChart = ({ apiUrl }) => {
  const [chartData, setChartData] = useState({});
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(apiUrl);
        const data = response.data;

        let counts = {};

        // Check if the API returns an array or an object with distinct keys
        if (Array.isArray(data)) {
          // If the data is an array, count occurrences of each item
          counts = data.reduce((accumulator, item) => {
            accumulator[item] = (accumulator[item] || 0) + 1;
            return accumulator;
          }, {});
        } else if (typeof data === 'object') {
          // If the data is an object, use its keys as labels
          counts = Object.keys(data).reduce((accumulator, key) => {
            accumulator[key] = data[key];
            return accumulator;
          }, {});
        }

        setChartData({
          labels: Object.keys(counts),
          datasets: [{
            data: Object.values(counts),
            backgroundColor: [
              '#ef476f',
              '#ffd166',
              '#06d6a0',
              '#118ab2',
              '#073b4c'
            ]
          }]
        });

        setLoading(false);
      } catch (error) {
        console.error('Error fetching data:', error);
        setLoading(false);
      }
    };

    fetchData();
  }, [apiUrl]);

  return (
    <div style={{ height: '250px', width: '250px' }}>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Pie data={chartData} options={{ maintainAspectRatio: true, responsive: false }}/>
      )}
    </div>
  );
};

export default PieChart;