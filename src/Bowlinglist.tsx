import { useState } from 'react';
import { Bowler } from './types/Bowling'; // Fix import syntax

function BowlingList() {
  const [Bowlers, setBowlers] = useState<Bowler[]>([]);
  const fetchBowler = async () => {
    const response = await fetch('http://localhost:4040/api/Bowling');
    const data = await response.json();
    setBowlers(data);
  };
  fetchBowler();

  return (
    <>
      <h1>Bowler List</h1>
      <table>
        <thead>
          <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Phone Number</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Team ID</th>
          </tr>
        </thead>
        <tbody>
          {Bowlers.map((b) => (
            <tr key={b.bowlerId}>
              {' '}
              {/* Assuming Bowler has a unique `bowlerId` */}
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerPhoneNumber}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.team.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;
