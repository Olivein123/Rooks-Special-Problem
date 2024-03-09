import './Personal.css';
import React from 'react';
import MuiNavBar from '../components/MuiNavBar';
import PieChartFundSource from '../components/PieChartFundSource';
function Personal(){
    return (
        <div>
            <MuiNavBar/>
            Personal Profile Page
            <div className='chart'>
                Fund Source
                <PieChartFundSource/>
            </div>
        </div>
    );
}
export default Personal;