import './Student.css';
import React, { useState, useEffect } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';

const Students = () => {
  const [studentData, setStudentData] = useState([]);

  useEffect(() => {
    // Fetch student data from the API
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
      <div className='stcontent'>
        <Typography variant="h4" component="h1" gutterBottom>
          Student Data
        </Typography>
        {studentData.map((student, index) => (
          <Box key={index} sx={{ border: '1px solid #ccc', borderRadius: '4px', padding: '16px', marginBottom: '16px' }}>
            <Typography variant="h6" component="h2" gutterBottom>
              Student ID: {student.personalInformation.studentId}
            </Typography>
            <Typography variant="body1" component="p" gutterBottom>
              Course: {student.collegeInformation.course}
            </Typography>
          </Box>
        ))}
      </div>
    );
};
export default Students