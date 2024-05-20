import React from 'react';
import MuiNavBar from '../NavBar/MuiNavBar';
import './Layout.css'
import Footer from '../FooterComponent/Footer';

const Layout = ({ children }) => {
  return (
    <div className='page'>
      <MuiNavBar />
      <div className="lcontent">
        {children}
      </div>
      <Footer/>
    </div>
  );
};

export default Layout;
