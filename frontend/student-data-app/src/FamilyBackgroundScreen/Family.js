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
            <div className='content'>
                <div className='chart'>
                    Mother's Occupation
                    <BarChartDistinctData apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=1" />
                </div>
                <div className='chart'>
                    Father's Occupation
                    <BarChartDistinctData apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=2" />
                </div>
                <div className='chart'>
                    Total Income
                    <BarChartDistinctData apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=3" />
                </div>
                <div className='chart'>
                    Total Number of Siblings
                    <PieChart apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=4" />
                </div>
                <div className='chart'>
                    Dependent Siblings
                    <PieChart apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=5" />
                </div>
                <div className='chart'>
                    Graduated Siblings
                    <PieChart apiUrl="https://localhost:7025/api/GetStudentFamilyProfileInformation?choice=6" />
                </div>
            </div>
        </div>
    );
}
export default Family;