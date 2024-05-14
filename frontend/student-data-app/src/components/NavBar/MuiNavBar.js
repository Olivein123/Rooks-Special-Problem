import './MuiNavBar.css'
import React from 'react'
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemText from '@mui/material/ListItemText';
import { Link } from 'react-router-dom';
const MuiNavBar = () => {
  const [open, setOpen] = React.useState(false);

  const toggleDrawer = (newOpen) => () => {
    setOpen(newOpen);
  };

  const DrawerList = (
    <Box sx={{ width: 250 }} role="presentation" onClick={toggleDrawer(false)}>
      <List>
        {[
          {text: 'Home', route:'/'},
          {text: 'Personal Profile', route:'/personal-info'},
          {text: 'Family Background', route: '/family-bg'},
          {text: 'SHS Information', route: '/senior-info'},
          {text: 'College Information', route: '/college-info'},
          {text: 'Retention Rate Page', route: '/retention-rate'}
        ].map((item, index) => (
          <ListItem key={item.text} disablePadding>
            <ListItemButton component={Link} to={item.route}>
              <ListItemText primary={item.text} sx={{ color: '#800000', fontWeight: 'bold'}}/>
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </Box>
  );

  return (
    <Box sx={{ flexGrow: 1 }}>
    <AppBar className="navbar" position="fixed"sx={{ background: 'linear-gradient(to right, #F6C311, #8A252C)' }}>
      <Toolbar>
        <IconButton size="large" edge="start" color="inherit" aria-label="menu" sx={{ mr: 2 }} onClick={toggleDrawer(true)}>
          <MenuIcon sx={{ color: '#800000' }}/>
        </IconButton>
        <Drawer open={open} onClose={toggleDrawer(false)}>
        {DrawerList}
      </Drawer>
        <Typography variant="h6" component="div" sx={{ flexGrow: 1, fontWeight: 'bold', color: '#800000'}}>
          CCS Students Data 
        </Typography>
      </Toolbar>
    </AppBar>
    <Box></Box>
  </Box>
  );
}

export default MuiNavBar