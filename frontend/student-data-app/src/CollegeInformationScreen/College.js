import './College.css';
import React from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
function College(){
    return (
        <div>
            <MuiNavBar/>
            College Information Page
            <div className='ccontent'>
            <div className='cchart-container'>
                <PieChartWrapper title="Course" choice="1" />
                <PieChartWrapper title="Year Level" choice="2" />
                <BarChartWrapper title="Programming 1 Professor" choice="3" />
                <PieChartWrapper title="Mode of Delivery" choice="4" />
                <BarChartWrapper title="Has Scholarship" choice="5" />
                <PieChartWrapper title="Scholarship type" choice="6" />
                <PieChartWrapper title="Has programming experience" choice="7" />
                <BarChartWrapper title="Programming languages known" choice="8" />
                <PieChartWrapper title="Has device" choice="9" />
                <PieChartWrapper title="Currently within cebu" choice="10" />
                <BarChartWrapper title="Current staying place" choice="11" />
                <PieChartWrapper title="Has enough studying place" choice="12" />
                <BarChartWrapper title="Mode of transportation to school" choice="13" />
                <BarChartWrapper title="Number of Commutes to school" choice="14" />
                <BarChartWrapper title="Commute duration to school" choice="15" />
                <BarChartWrapper title="Feeling arriving to school" choice="16" />
                <BarChartWrapper title="Mode of transportation going home" choice="17" />
                <BarChartWrapper title="Number of Commutes going home" choice="18" />
                <BarChartWrapper title="Commute duration going home" choice="19" />
                <BarChartWrapper title="Feeling arriving to school" choice="20" />
                {/* <BarChartWrapper title="Reason for pursuing CS/IT" choice="21" />    */}
            </div>
            </div>
        </div>
    );
}
function PieChartWrapper({ title, choice }) {
    return (
        <div className='cchart'>
            {title}
            <PieChart apiUrl={`https://localhost:7025/api/GetStudentCollegeInformation?choice=${choice}`} />
        </div>
    );
}
function BarChartWrapper({ title, choice }) {
    return (
        <div className='cchart'>
            {title}
            <BarChartDistinctData apiUrl={`https://localhost:7025/api/GetStudentCollegeInformation?choice=${choice}`} />
        </div>
    );
}
export default College;