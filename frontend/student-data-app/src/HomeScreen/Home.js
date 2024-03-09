import './Home.css';
import axios from 'axios';
import React, { useState, useEffect } from 'react';
import MuiNavBar from '../components/MuiNavBar';
function Home(){
    const [studentData, setStudentData] = useState(null);

    useEffect(() => {
      const fetchData = async () => {
        try {
          const response = await axios.get('https://localhost:7025/api/GetStudentInformation/170545444');
          setStudentData(response.data);
        } catch (error) {
          console.error('Error fetching student data:', error);
        }
      };
  
      fetchData();
    }, []);

    return (
        <div>
            <MuiNavBar/>
            Home Page
            <div>
            <div>
      {studentData ? (
        <div>
                    <p>Student ID: {studentData.studentId}</p>
                    <p>Lastname: {studentData.lastname}</p>
                    <p>Firstname: {studentData.firstname}</p>
                    <p>Middlename: {studentData.middlename}</p>
                    <p>Address: {studentData.address}</p>
                    <p>Fund Source: {studentData.fundSource}</p>
                    <p>Fund Source Type: {studentData.fundSourceType}</p>
                    <p>Job: {studentData.job}</p>
                    <p>Salary Enough: {studentData.salaryEnough}</p>
                    <p>Salary Range: {studentData.salaryRange}</p>
                    </div>
                ) : (
                    <p>Loading...</p>
                )}
                </div>
            </div>
        </div>
    );
}
export default Home;