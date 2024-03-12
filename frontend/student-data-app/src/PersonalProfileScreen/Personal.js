import './Personal.css';
import React, { useState } from 'react';
import MuiNavBar from '../components/MuiNavBar';
import BarChartDistinctData from '../components/BarChart';
import PieChart from '../components/PieChart';
function Personal(){
    const [showLabels, setShowLabels] = useState(true); // State to track whether to show labels

    const handleToggleLabels = () => {
        setShowLabels(!showLabels); // Toggle the state when clicked
    };
    return (
        <div>
            <MuiNavBar/>
            Personal Profile Page
            <div className='pcontent'>
            
                <div className='pchart' onClick={handleToggleLabels}>
                    Address
                    <BarChartDistinctData apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=1" />
                </div>
                <div className='pchart' onClick={handleToggleLabels}>
                    Source of Funds Support
                    <BarChartDistinctData apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=2" />
                </div>
                <div className='pchart'onClick={handleToggleLabels}>
                    Self-funded Students' Fund Source Type
                    <PieChart apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=3" />
                </div>
            </div>
        </div>
    );
}
export default Personal;