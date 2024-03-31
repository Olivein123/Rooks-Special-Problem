import './Personal.css';
import '../App.css';
import React, { useState } from 'react';
import MuiNavBar from '../components/MuiNavBar';
import BottomDrawer from '../components/BottomDrawer';
import BarChartDistinctData from '../components/BarChart';
import PieChart from '../components/PieChart';
import Typography from '@mui/material/Typography';
function Personal(){
    const [isBottomDrawerOpen, setIsBottomDrawerOpen] = useState(false);
    const [chartData, setChartData] = useState([]);

    const handleChartClick = async (apiUrl) => {
        try {
            // Fetch data from the specific API URL
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Failed to fetch data');
            }
            const responseData = await response.json(); // Read the response as JSON
            console.log(responseData); // Log the response data
            const dataMap = new Map();
            responseData.forEach(item => {
                dataMap.set(item, dataMap.has(item) ? dataMap.get(item) + 1 : 1);
            });
            const distinctDataWithCount = Array.from(dataMap.entries()); // Get distinct data with counts
            setChartData(distinctDataWithCount); // Set the fetched distinct data with counts to state
            setIsBottomDrawerOpen(true); // Open the bottom drawer
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };
    return (
        <div>
            <MuiNavBar/>
            <div className='pcontent'>
                <Typography variant="h3" gutterBottom>
                    Personal Profile
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant personal information of CCS students
                </Typography>
                <div className='pchart-container'>
                    <BarChartWrapper title="Address" choice="1" handleChartClick={handleChartClick} />
                    <BarChartWrapper title="Fund Source" choice="2" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Fund Type" choice="3" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Job" choice="4" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Salary Enough" choice="5" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Salary Range" choice="6" handleChartClick={handleChartClick} />
                </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={setIsBottomDrawerOpen} data={chartData} />
        </div>
    );
}
function PieChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/PersonalInformation?choice=${choice}`;

    return (
        <div className='pchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <PieChart apiUrl={apiUrl} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/PersonalInformation?choice=${choice}`;

    return (
        <div className='pchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} />
        </div>
    );
}
export default Personal;