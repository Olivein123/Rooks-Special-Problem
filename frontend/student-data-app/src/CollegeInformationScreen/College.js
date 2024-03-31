import './College.css';
import React,{useState} from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
import BottomDrawer from '../components/BottomDrawer';

function College(){
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
            College Information Page
            <div className='ccontent'>
            <div className='cchart-container'>
                <PieChartWrapper title="Course" choice="1" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Year Level" choice="2" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Programming 1 Professor" choice="3" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Mode of Delivery" choice="4" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Has Scholarship" choice="5" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Scholarship type" choice="6" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Has programming experience" choice="7" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Programming languages known" choice="8" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Has device" choice="9" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Currently within cebu" choice="10" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Current staying place" choice="11" handleChartClick={handleChartClick}/>
                <PieChartWrapper title="Has enough studying place" choice="12" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Mode of transportation to school" choice="13" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Number of Commutes to school" choice="14" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Commute duration to school" choice="15" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Feeling arriving to school" choice="16" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Mode of transportation going home" choice="17" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Number of Commutes going home" choice="18" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Commute duration going home" choice="19" handleChartClick={handleChartClick}/>
                <BarChartWrapper title="Feeling arriving to school" choice="20" handleChartClick={handleChartClick}/>
            </div>
            </div>
            <BottomDrawer open={isBottomDrawerOpen} onClose={setIsBottomDrawerOpen} data={chartData} />
        </div>
    );
}

function PieChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/CollegeInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <PieChart apiUrl={apiUrl} />
        </div>
    );
}

function BarChartWrapper({ title, choice, handleChartClick }) {
    // Construct the apiUrl
    const apiUrl = `https://localhost:7025/api/CollegeInformation?choice=${choice}`;

    return (
        <div className='fchart' onClick={() => handleChartClick(apiUrl)}>
            {title}
            <BarChartDistinctData apiUrl={apiUrl} />
        </div>
    );
}
export default College;