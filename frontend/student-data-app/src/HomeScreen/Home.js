import './Home.css';
import React, { useState, useEffect } from 'react';
import MuiNavBar from '../components/MuiNavBar';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import PieChart from '../components/PieChart';

function Home(){
  const [studentData, setStudentData] = useState([]);

  useEffect(() => {
    
    const fetchStudentData = async () => {
      try {
        const response = await fetch('https://localhost:7025/api/Student');
        if (!response.ok) {
          throw new Error('Failed to fetch student data');
        }
        const data = await response.json();
        setStudentData(data);
      } catch (error) {
        console.error('Error fetching student data:', error);
      }
    };

    fetchStudentData();
  }, []);
  
    return (
        <div>
            <MuiNavBar/>
            <div className='hcontent'>
              <Typography variant="h4" component="h1" gutterBottom>
              </Typography>
              <div className='hchart'>
                <PieChart apiUrl="https://localhost:7025/api/CollegeInformation?choice=1"/>
              </div>
            </div>
        </div>
    );
};
export default Home;