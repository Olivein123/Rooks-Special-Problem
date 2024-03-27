import './Family.css';
import React from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChart from '../components/PieChart';
import BarChartDistinctData from '../components/BarChart';
function Family(){
    return (
        <div>
            <MuiNavBar/>
            Family Background Page
            <div className='fcontent'>
            <div className='fchart-container'>
                <BarChartWrapper title="Mother's Occupation" choice="1" />
                <BarChartWrapper title="Father's Occupation" choice="2" />
                <PieChartWrapper title="Total Income" choice="3" />
                <PieChartWrapper title="Total Number of Siblings" choice="4" />
                <PieChartWrapper title="Parent/Guardian-Dependent Siblings" choice="5" />
                <PieChartWrapper title="Graduated Siblings" choice="6" />    
            </div>
            </div>
        </div>
    );
}

function PieChartWrapper({ title, choice }) {
    return (
        <div className='fchart'>
            {title}
            <PieChart apiUrl={`https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=${choice}`} />
        </div>
    );
}
function BarChartWrapper({ title, choice }) {
    return (
        <div className='fchart'>
            {title}
            <BarChartDistinctData apiUrl={`https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=${choice}`} />
        </div>
    );
}
export default Family;