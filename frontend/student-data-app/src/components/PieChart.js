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

        // Count occurrences of each item
        counts = data.reduce((accumulator, item) => {
          const label = item !== '' ? item : nullLabel;
          accumulator[label] = (accumulator[label] || 0) + 1;
          return accumulator;
        }, {});

        // Get labels and datasets
        const labels = Object.keys(counts).sort(); // Sort labels alphabetically
        const datasets = [{
          data: labels.map(label => counts[label]),
          backgroundColor: [
            '#8A252C', // maroon
            '#F6C311', // gold
            '#CC5500', // burnt orange
            '#191970', // midnight blue
            '#228B22', // forest green
            '#FFDAB9', // peach
            '#87CEEB'  // sky blue
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
        display: false,
        position: 'top',
      },
      tooltip: {
        enabled: true,
        callbacks: {
          label: function(context) {
            const label = context.label || '';
            const value = context.raw || 0;
            return `${label}: ${value}`;
          }
        }
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
    <div style={{ position: 'center', width: '85%', height: '85%', overflow: 'hidden' }}>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Pie data={chartData} options={chartOptions} />
      )}
    </div>
  );
};

export default PieChart;
