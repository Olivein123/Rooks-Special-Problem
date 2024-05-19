import './Family.css';
import '../App.css';
import React, { useState } from 'react';
import BottomDrawer from '../components/BottomDrawer';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import Typography from '@mui/material/Typography';

function Family() {
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
        <div className='fcontent'>
            <Typography variant="h3" gutterBottom>
                Family Background
            </Typography>
            <Typography variant="h6" gutterBottom>
                This page contains the relevant family background information of CCS students
            </Typography>
            <div className='fchart-container'>
                <BarChartWrapper title="Mother's Occupation" choice="1" handleChartClick={handleChartClick} nullLabel="No Occupation"/>
                <BarChartWrapper title="Father's Occupation" choice="2" handleChartClick={handleChartClick} nullLabel="No Occupation"/>
                <PieChartWrapper title="Total Income" choice="3" handleChartClick={handleChartClick} nullLabel="No Income"/>
                <PieChartWrapper title="Total Number of Siblings" choice="4" handleChartClick={handleChartClick} nullLabel="None"/>
                <PieChartWrapper title="Parent/Guardian-Dependent Siblings" choice="5" handleChartClick={handleChartClick} nullLabel="None"/>
                <PieChartWrapper title="Graduated Siblings" choice="6" handleChartClick={handleChartClick} nullLabel="None"/>
        </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/FamilyProfileInformation?choice=${choice}`;
    return (
        <div className='chart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/FamilyProfileInformation?choice=${choice}`;
    return (
        <div className='chart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} nullLabel={nullLabel}/>
        </div>
    );
}

export default Family;
