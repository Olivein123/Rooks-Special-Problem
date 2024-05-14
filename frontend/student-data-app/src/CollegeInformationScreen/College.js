import './College.css';
import React,{useState} from 'react';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import BottomDrawer from '../components/BottomDrawer';
import Typography from '@mui/material/Typography';

function College(){
    const [isBottomDrawerOpen, setIsBottomDrawerOpen] = useState(false);
    const [chartData, setChartData] = useState([]);
    const [selectedChartNullLabel, setSelectedChartNullLabel] = useState(""); 
    
    const processData = (responseData, delimiter) => {
        const counts = {};
        responseData.forEach(item => {
            const types = item.split(delimiter);
            types.map(type => type.trim()).forEach(type => {
                counts[type] = (counts[type] || 0) + 1;
            });
        });
        
        // Merge labels that are similar but have different count
        const mergedCounts = {};
        Object.entries(counts).forEach(([label, count]) => {
            // Check if the label exists with a different count
            const similarLabel = Object.keys(mergedCounts).find(mergedLabel => {
                return label.includes(mergedLabel) || mergedLabel.includes(label);
            });
            if (similarLabel) {
                mergedCounts[similarLabel] += count;
            } else {
                mergedCounts[label] = count;
            }
        });
    
        return Object.entries(mergedCounts);
    };
    
    const handleChartClick = async (apiUrl, delimiter,nullLabel) => {
        try {
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Failed to fetch data');
            }
            const responseData = await response.json();
            console.log(responseData);
            
            // Process the data using the reusable function
            const distinctDataWithCount = processData(responseData, delimiter);
            setChartData(distinctDataWithCount);
            setSelectedChartNullLabel(nullLabel);
            setIsBottomDrawerOpen(true);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };
    
    return (
        <div className='ccontent'>
                <Typography variant="h3" gutterBottom>
                    College Information
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant college information of CCS students
                </Typography>
                <div className='cchart-container'>
                    <PieChartWrapper title="Course" choice="1" handleChartClick={handleChartClick} nullLabel=""/>
                    <PieChartWrapper title="Year Level" choice="2" handleChartClick={handleChartClick}nullLabel=""/>
                    <BarChartWrapper title="Programming 1 Professor" choice="3" handleChartClick={handleChartClick}nullLabel="No Data"/>
                    <PieChartWrapper title="Mode of Delivery" choice="4" handleChartClick={handleChartClick}nullLabel="No Data"/>
                    <BarChartWrapper title="Has Scholarship" choice="5" handleChartClick={handleChartClick}nullLabel="No Data"/>
                    <PieChartWrapper title="Scholarship type" choice="6" handleChartClick={handleChartClick}nullLabel="No Scholarship"/>
                    <PieChartWrapper title="Has programming experience" choice="7" handleChartClick={handleChartClick}nullLabel="None"/>
                    <BarChartWrapper title="Programming languages known" choice="8" handleChartClick={handleChartClick} nullLabel="None"/>
                    <PieChartWrapper title="Has device" choice="9" handleChartClick={handleChartClick} nullLabel="None"/>
                    <PieChartWrapper title="Currently within cebu" choice="10" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <BarChartWrapper title="Current staying place" choice="11" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <PieChartWrapper title="Has enough studying place" choice="12" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <BarChartWrapper title="Mode of transportation to school" choice="13" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <BarChartWrapper title="Number of Commutes to school" choice="14" handleChartClick={handleChartClick}nullLabel="Does not Commute"/>
                    <BarChartWrapper title="Commute duration to school" choice="15" handleChartClick={handleChartClick} nullLabel="Does not Commute"/>
                    <BarChartWrapper title="Feeling arriving to school" choice="16" handleChartClick={handleChartClick}nullLabel="No Data"/>
                    <BarChartWrapper title="Mode of transportation going home" choice="17" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <BarChartWrapper title="Number of Commutes going home" choice="18" handleChartClick={handleChartClick} nullLabel="Does not Commute"/>
                    <BarChartWrapper title="Commute duration going home" choice="19" handleChartClick={handleChartClick} nullLabel="Does not Commute"/>
                    <BarChartWrapper title="Feeling arriving to school" choice="20" handleChartClick={handleChartClick} nullLabel="No Data"/>
                    <PieChartWrapper title="Reason for pursuing CS/IT" choice="21" handleChartClick={handleChartClick} nullLabel="No Data"/>
                </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick, nullLabel}) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/CollegeInformation?choice=${choice}`;
    const delimiter=';';
    return (
        <div className='cchart' onClick={() => handleChartClick(apiUrl, delimiter, nullLabel)}>
            {title}
            <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/CollegeInformation?choice=${choice}`;
    const delimiter=';';
    return (
        <div className='cchart' onClick={() => handleChartClick(apiUrl, delimiter, nullLabel)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} nullLabel={nullLabel}/>
        </div>
    );
}
export default College;