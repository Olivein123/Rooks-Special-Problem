import './Senior.css';
import '../App.css';
import React,{useState} from 'react';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import BottomDrawer from '../components/BottomDrawer';
import Typography from '@mui/material/Typography';

function Senior(){
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
        <div className='scontent'>
                <Typography variant="h3" gutterBottom>
                    Senior High School Information
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant SHS information of CCS students
                </Typography>
                <div className='schart-container'>
                        <PieChartWrapper title="Type of School" choice="1" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="Joined Science High" choice="2" handleChartClick={handleChartClick} nullLabel="Private Senior High School"/>
                        <PieChartWrapper title="Science High School" choice="3" handleChartClick={handleChartClick} nullLabel="Not in Science High School"/>
                        <PieChartWrapper title="Senior High School" choice="4" handleChartClick={handleChartClick} nullLabel="Science High School"/>
                        <PieChartWrapper title="Strand" choice="5" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="With Honors" choice="6" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="In Top 10" choice="7" handleChartClick={handleChartClick} nullLabel="Not With Honors"/>
                        <PieChartWrapper title="Academic Rank" choice="8" handleChartClick={handleChartClick} nullLabel="Not in top 10"/>
                        <PieChartWrapper title="Academic Excellence Award" choice="9" handleChartClick={handleChartClick} nullLabel="Not With Honors"/>
                        <PieChartWrapper title="English Grade Range" choice="10" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="Math Grade Range" choice="11" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="Science Grade Range" choice="12" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="GPA" choice="13" handleChartClick={handleChartClick} nullLabel="No Data"/>
                        <PieChartWrapper title="Programming 1 Grade" choice="14" handleChartClick={handleChartClick} nullLabel="No Data"/>
                </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={() => setIsBottomDrawerOpen(false)} data={chartData} nullLabel={selectedChartNullLabel} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/SeniorHighSchoolInformation?choice=${choice}`;

    return (
        <div className='chart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick, nullLabel }) {
    const apiUrl = `https://localhost:7025/api/SeniorHighSchoolInformation?choice=${choice}`;

    return (
        <div className='chart' onClick={() => handleChartClick(apiUrl, nullLabel)}>
            {title}
            <PieChart apiUrl={apiUrl} nullLabel={nullLabel} />
        </div>
    );
}
export default Senior;