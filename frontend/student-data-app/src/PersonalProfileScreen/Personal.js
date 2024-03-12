import './Personal.css';
import React from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChartFundSource from '../components/PieChartFundSource';
function Personal(){
    return (
        <div>
            <MuiNavBar/>
            Personal Profile Page
            <div className='content'>
            
                <div className='chart'>
                    Address
                    <PieChartFundSource apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=1" />
                </div>
                <div className='chart'>
                    Fund Source
                    <PieChartFundSource apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=2" />
                </div>
                <div className='chart'>
                    Fund Type
                    <PieChartFundSource apiUrl="https://localhost:7025/api/GetStudentPersonalInformation?choice=3" />
                </div>
            </div>
        </div>
    );
}
export default Personal;