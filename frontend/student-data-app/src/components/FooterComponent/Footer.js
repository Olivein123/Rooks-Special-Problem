import * as React from 'react';
import Box from '@mui/material/Box';
import BottomNavigation from '@mui/material/BottomNavigation';
import BottomNavigationAction from '@mui/material/BottomNavigationAction';
import RestoreIcon from '@mui/icons-material/Restore';
import FavoriteIcon from '@mui/icons-material/Favorite';
import LocationOnIcon from '@mui/icons-material/LocationOn';

export default function Footer() {
  const [value, setValue] = React.useState(0);

  return (
    <Box className='footbox'>
      <BottomNavigation className='footer' sx={{ height: 73, background: 'linear-gradient(to right, #F6C311, #8A252C)' }}>
        {/* <BottomNavigationAction label="Recents" icon={<RestoreIcon />} />
        <BottomNavigationAction label="Favorites" icon={<FavoriteIcon />} />
        <BottomNavigationAction label="Nearby" icon={<LocationOnIcon />} /> */}
        <p>Student Data Visualizer  | CS 498 | Thesis Project</p>
        <p>Team Rooks | A.Y. 2023-2024</p>
      </BottomNavigation>
    </Box>
  );
}