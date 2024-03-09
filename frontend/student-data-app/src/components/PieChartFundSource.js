import React, { useEffect, useState } from 'react';
import { Pie } from 'react-chartjs-2';
import axios from 'axios';
import 'chart.js/auto';

const PieChartFundSource = () => {
    const [chartData, setChartData] = useState({});
  const [loading, setLoading] = useState(true); // State to track loading status

  useEffect(() => {
    const fetchData = async () => {
      try {
        // Fetch data from localhost API
        const response = await axios.get('https://localhost:7025/api/GetStudentPersonalInformation?choice=3');
        const data = response.data;

        // Count occurrences of each category
        const counts = {
          "Parents/Guardians": 0,
          "Me": 0
        };

        data.forEach(choice => {
          counts[choice]++;
        });

        // Set chart data
        setChartData({
          labels: Object.keys(counts),
          datasets: [{
            data: Object.values(counts),
            backgroundColor: [
              '#6E090C',
              '#FFB302'
            ]
          }]
        });

        // Data is now available, set loading to false
        setLoading(false);
      } catch (error) {
        console.error('Error fetching data:', error);
        // Handle error, set loading to false if necessary
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  return (
    <div>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <Pie data={chartData} />
      )}
    </div>
  );
  };
  
  export default PieChartFundSource;
