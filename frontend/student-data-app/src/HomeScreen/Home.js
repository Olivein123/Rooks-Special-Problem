import './Home.css';
import React, { useState, useEffect } from 'react';
import MuiNavBar from '../components/MuiNavBar';
import BottomDrawer from '../components/BottomDrawer';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';

function Home(){
  const [studentData, setStudentData] = useState([]);
  const [isBottomDrawerOpen, setIsBottomDrawerOpen] = useState(false);
    const [chartData, setChartData] = useState([]);
    const [selectedChartNullLabel, setSelectedChartNullLabel] = useState(""); // Store the null label for the selected chart

    const handleChartClick = async (apiUrl, nullLabel) => {
        try {
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Failed to fetch data');
            }
            const responseData = await response.json(); 
            console.log(responseData); 
            const dataMap = new Map();
            responseData.forEach(item => {
                dataMap.set(item, dataMap.has(item) ? dataMap.get(item) + 1 : 1);
            });
            const distinctDataWithCount = Array.from(dataMap.entries()); 
            setChartData(distinctDataWithCount); 
            setSelectedChartNullLabel(nullLabel); // Update the null label for the selected chart
            setIsBottomDrawerOpen(true); // Open the bottom drawer
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };

  useEffect(() => {
    
    const fetchStudentData = async () => {
      try {
        const response = await fetch('https://localhost:7025/api/Student');
        if (!response.ok) {
          throw new Error('Failed to fetch student data');
        }
        const data = await response.json();
        setStudentData(data);
      } catch (error) {
        console.error('Error fetching student data:', error);
      }
    };

    fetchStudentData();
  }, []);
  
    return (
        <div>
            <MuiNavBar/>
            <div className='hcontent'>
            <Typography variant="h3" gutterBottom>
                    Family Background
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant family background information of CCS students
                </Typography>
                <div className='hchart-container'>
                  <PieChartWrapper title="Graduated Siblings" api="https://localhost:7025/api/CollegeInformation?choice=1" handleChartClick={handleChartClick} nullLabel="None"/>
                </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, api, handleChartClick, nullLabel }) {
  const apiUrl = api;
  return (
      <div className='pchart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
          {title}
          <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
      </div>
  );
}

function BarChartWrapper({ title, api, handleChartClick, nullLabel }) {
  const apiUrl = api;
  return (
      <div className='pchart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
          {title}
          <BarChartDistinctData apiUrl={apiUrl} nullLabel={nullLabel}/>
      </div>
  );
}
export default Home;