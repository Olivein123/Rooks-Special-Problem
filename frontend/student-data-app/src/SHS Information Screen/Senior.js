import './Senior.css';
import React from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChart from '../components/PieChart';
function Senior(){
    return (
        <div>
            <MuiNavBar/>
            SHS Information Page
            <div className='scontent'>
            <div className='schart-container'>
                    <PieChartWrapper title="Type of School" choice="1" />
                    <PieChartWrapper title="Joined Science High" choice="2" />
                    <PieChartWrapper title="Science High School" choice="3" />
                    <PieChartWrapper title="Senior High School" choice="4" />
                    <PieChartWrapper title="Strand" choice="5" />
                    <PieChartWrapper title="With Honors" choice="6" />
                    <PieChartWrapper title="In Top 10" choice="7" />
                    <PieChartWrapper title="Academic Rank" choice="8" />
                    <PieChartWrapper title="Academic Excellence Award" choice="9" />
                    <PieChartWrapper title="English Grade Range" choice="10" />
                    <PieChartWrapper title="Math Grade Range" choice="11" />
                    <PieChartWrapper title="Science Grade Range" choice="12" />
                    <PieChartWrapper title="GPA" choice="13" />
                    <PieChartWrapper title="Programming 1 Grade" choice="14" />
                </div>
            </div>
        </div>
    );
}

function PieChartWrapper({ title, choice }) {
    return (
        <div className='schart'>
            {title}
            <PieChart apiUrl={`https://localhost:7025/api/GetStudentSeniorHighSchoolInformation?choice=${choice}`} />
        </div>
    );
}
export default Senior;