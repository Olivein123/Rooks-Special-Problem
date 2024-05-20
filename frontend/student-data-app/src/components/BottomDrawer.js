import * as React from 'react';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';

export default function BottomDrawer({ open, onClose, data, nullLabel }) {
  // Replace null values with the specified nullLabel in the data array
  const modifiedData = data.map(([item, count]) => {
    return [item !== '' ? item : nullLabel, count];
  });

  const list = (
    <Box
      sx={{ height: 500 }} // Adjust width as needed
      role="presentation"
      onKeyDown={(event) => event.stopPropagation()} // Prevent closing on key press
    >
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>Data</TableCell>
            <TableCell>Count</TableCell> {/* New column for count */}
          </TableRow>
        </TableHead>
        <TableBody>
          {modifiedData.map(([item, count], index) => (
            <TableRow key={index}>
              <TableCell>{item}</TableCell>
              <TableCell>{count}</TableCell> {/* Render count in a separate column */}
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </Box>
  );

  return (
    <Drawer
      anchor="bottom"
      open={open}
      onClose={() => onClose(false)}
    >
      <div onClick={(event) => event.stopPropagation()}>{list}</div>
    </Drawer>
  );
}
