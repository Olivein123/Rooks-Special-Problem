import './Family.css';
import React, { useState } from 'react';
import MuiNavBar from '../components/MuiNavBar';
import BottomDrawer from '../components/BottomDrawer';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import Typography from '@mui/material/Typography';

function Family() {
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
            <MuiNavBar />
            <div className='fcontent'>
                <Typography variant="h3" gutterBottom>
                    Family Background
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant family background information of CCS students
                </Typography>
                <div className='fchart-container'>
                    <BarChartWrapper title="Mother's Occupation" choice="1" handleChartClick={handleChartClick} />
                    <BarChartWrapper title="Father's Occupation" choice="2" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Total Income" choice="3" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Total Number of Siblings" choice="4" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Parent/Guardian-Dependent Siblings" choice="5" handleChartClick={handleChartClick} />
                    <PieChartWrapper title="Graduated Siblings" choice="6" handleChartClick={handleChartClick} />
                </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={setIsBottomDrawerOpen} data={chartData} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/FamilyProfileInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <PieChart apiUrl={apiUrl} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/FamilyProfileInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} />
        </div>
    );
}

export default Family;
