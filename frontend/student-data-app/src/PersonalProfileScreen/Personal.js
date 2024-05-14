import './Personal.css';
import '../App.css';
import React, { useState } from 'react';
import MuiNavBar from '../components/NavBar/MuiNavBar';
import BottomDrawer from '../components/BottomDrawer';
import BarChartDistinctData from '../components/BarChart';
import PieChart from '../components/PieChart';
import Typography from '@mui/material/Typography';

function Personal() {
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
        <div>
            <div className='pcontent'>
                <Typography variant="h3" gutterBottom>
                    Personal Profile
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant personal information of CCS students
                </Typography>
                <div className='pchart-container'>
                    <BarChartWrapper title="Address" choice="1" handleChartClick={handleChartClick} nullLabel="No Address" />
                    <BarChartWrapper title="Fund Source" choice="2" handleChartClick={handleChartClick} nullLabel="No Fund Source" />
                    <PieChartWrapper title="Fund Type" choice="3" handleChartClick={handleChartClick} nullLabel="None" />
                    <PieChartWrapper title="Job" choice="4" handleChartClick={handleChartClick} nullLabel="No Job" />
                    <PieChartWrapper title="Salary Enough" choice="5" handleChartClick={handleChartClick} nullLabel="No Job" />
                    <PieChartWrapper title="Salary Range" choice="6" handleChartClick={handleChartClick} nullLabel="No Job" />
                </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/PersonalInformation?choice=${choice}`;

    return (
        <div className='pchart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/PersonalInformation?choice=${choice}`;
    return (
        <div className='pchart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} nullLabel={nullLabel}/>
        </div>
    );
}
export default Personal;    