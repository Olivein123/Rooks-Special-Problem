import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'; // Import BrowserRouter
import Home from './HomeScreen/Home'
import Personal from './PersonalProfileScreen/Personal';
import FamilyBackground from './FamilyBackgroundScreen/Family';
import Senior from './SHS Information Screen/Senior';
import College from './CollegeInformationScreen/College';
import RetentionRate from './RetentionRateScreen/RetentionRate';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path="/personal-info" element={<Personal />} />
        <Route path="/family-bg" element={<FamilyBackground />} />
        <Route path="/senior-info" element={<Senior />} />
        <Route path="/college-info" element={<College />} />
        <Route path="/retention-rate" element={<RetentionRate/>}/>
      </Routes>
    </Router>
  );
}

export default App;
