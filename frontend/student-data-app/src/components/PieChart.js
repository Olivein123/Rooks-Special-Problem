import React, { useEffect, useState } from 'react';
import { Pie } from 'react-chartjs-2';
import axios from 'axios';
import 'chart.js/auto';

const PieChart = ({ apiUrl, nullLabel }) => {
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
            const label = item !== ''? item : nullLabel;
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
  
        // Get labels and datasets
        const labels = Object.keys(counts).sort(); // Sort labels alphabetically
        const datasets = [{
          data: Object.values(counts),
          backgroundColor: [
            '#ef476f',
            '#ffd166',
            '#06d6a0',
            '#118ab2',
            '#073b4c'
          ]
        }];
  
        setChartData({ labels, datasets });
  
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
        position: 'right'
      }
    }
  };

  return (
    <div style={{ position: 'relative', width: '100%', height: '100%', overflow: 'hidden'}}>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Pie data={chartData} options={chartOptions}/>
      )}
    </div>
  );
};

export default PieChart;
