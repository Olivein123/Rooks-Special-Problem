import './Senior.css';
import React,{useState} from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import BottomDrawer from '../components/BottomDrawer';
import Typography from '@mui/material/Typography';

function Senior(){
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
            <div className='scontent'>
                <Typography variant="h3" gutterBottom>
                    Senior High School Information
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page contains the relevant SHS information of CCS students
                </Typography>
                <div className='schart-container'>
                        <PieChartWrapper title="Type of School" choice="1" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Joined Science High" choice="2" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Science High School" choice="3" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Senior High School" choice="4" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Strand" choice="5" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="With Honors" choice="6" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="In Top 10" choice="7" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Academic Rank" choice="8" />
                        <PieChartWrapper title="Academic Excellence Award" choice="9" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="English Grade Range" choice="10" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Math Grade Range" choice="11" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Science Grade Range" choice="12" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="GPA" choice="13" handleChartClick={handleChartClick}/>
                        <PieChartWrapper title="Programming 1 Grade" choice="14" handleChartClick={handleChartClick}/>
                </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={setIsBottomDrawerOpen} data={chartData} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/SeniorHighSchoolInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <PieChart apiUrl={apiUrl} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/SeniorHighSchoolInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} />
        </div>
    );
}
export default Senior;