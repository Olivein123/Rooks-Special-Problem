import './Home.css';
import '../App.css';
import React, { useState} from 'react';
import BottomDrawer from '../components/BottomDrawer';
import Typography from '@mui/material/Typography';
import PieChart from '../components/PieChart';

function Home(){
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
  
    return (
        <div className='hcontent'>
            <Typography variant="h3" gutterBottom>
                    Home Page
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant information of CCS students
                </Typography>
                <div className='hchart-container'>
                  <PieChartWrapper title="Enrolled Students" api="https://localhost:7025/api/CollegeInformation?choice=1" handleChartClick={handleChartClick} nullLabel="None"/>
                </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, api, handleChartClick, nullLabel }) {
  const apiUrl = api;
  return (
      <div className='hchart' onClick={() => handleChartClick(apiUrl, nullLabel)}style={{ backgroundColor: 'white' }}>
          {title}
          <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
      </div>
  );
}
export default Home;