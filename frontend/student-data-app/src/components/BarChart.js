import React, { useEffect, useState } from 'react';
import { Bar } from 'react-chartjs-2';
import axios from 'axios';
import 'chart.js/auto';

const BarChartDistinctData = ({ apiUrl,nullLabel }) => {
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
            const label = item !== '' ? item : nullLabel;
            accumulator[label] = (accumulator[label] || 0) + 1;
            return accumulator;
          }, {});
        } else if (typeof data === 'object') {
          // If the data is an object, use its keys as labels
          counts = Object.keys(data).reduce((accumulator, key) => {
            const value = data[key] !== '' ? data[key] : nullLabel;
            accumulator[key] = value;
            return accumulator;
          }, {});
        }

        setChartData({
          labels: Object.keys(counts),
          datasets: [{
            label: 'Occurrences',
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
    <div>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Bar data={chartData} />
      )}
    </div>
  );
};

export default BarChartDistinctData;
