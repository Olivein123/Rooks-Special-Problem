import * as React from 'react';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';

export default function BottomDrawer({ open, onClose, data }) {
  const list = (
    <Box
      sx={{ height: 500 }} // Adjust width as needed
      role="presentation"
      onClick={() => onClose(false)}
      onKeyDown={() => onClose(false)}
    >
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>Data</TableCell>
            <TableCell>Count</TableCell> {/* New column for count */}
          </TableRow>
        </TableHead>
        <TableBody>
          {data.map(([item, count], index) => ( // Destructure item and count
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
      {list}
    </Drawer>
  );
}
