import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Layout from './components/LayoutPage/Layout';
import Home from './HomeScreen/Home';
import Personal from './PersonalProfileScreen/Personal';
import FamilyBackground from './FamilyBackgroundScreen/Family';
import Senior from './SHS Information Screen/Senior';
import College from './CollegeInformationScreen/College';
import RetentionRate from './RetentionRateScreen/RetentionRate';

function App() {
  return (
    <Router>
      <Routes>
        <Route
          path="/"
          element={<Layout><Home /></Layout>}
        />
        <Route
          path="/personal-info"
          element={<Layout><Personal /></Layout>}
        />
        <Route
          path="/family-bg"
          element={<Layout><FamilyBackground /></Layout>}
        />
        <Route
          path="/senior-info"
          element={<Layout><Senior /></Layout>}
        />
        <Route
          path="/college-info"
          element={<Layout><College /></Layout>}
        />
        <Route
          path="/retention-rate"
          element={<Layout><RetentionRate /></Layout>}
        />
      </Routes>
    </Router>
  );
}

export default App;
