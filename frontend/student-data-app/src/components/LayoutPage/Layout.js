import React from 'react';
import MuiNavBar from '../NavBar/MuiNavBar';
import './Layout.css'

const Layout = ({ children }) => {
  return (
    <div className='page'>
      <MuiNavBar />
      <div className="lcontent">
        {children}
      </div>
    </div>
  );
};

export default Layout;
