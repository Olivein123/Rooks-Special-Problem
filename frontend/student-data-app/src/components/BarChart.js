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
              '#800000',//maroon
              '#FFD700',//gold
              '#CC5500',//burnt orange
              '#191970',//midnight blue
              '#228B22',//forest green
              '#FFDAB9',//peach
              '#87CEEB',
              
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
  const chartOptions = {
    maintainAspectRatio: true,
    responsive: true,
    plugins: {
      legend: {
        display: false,
        position: 'top',
      },
      tooltips: {
        enabled: false
      }
    },
    layout: {
      padding: {
        top: 0,
        right: 0,
        bottom: 0,
        left: 0,
      },
    },
  };

  return (
    <div>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Bar data={chartData} options={chartOptions}/>
      )}
    </div>
  );
};

export default BarChartDistinctData;
