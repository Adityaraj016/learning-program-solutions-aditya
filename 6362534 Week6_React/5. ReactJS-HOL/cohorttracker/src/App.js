import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  const sampleCohort = {
    name: "Web developement course",
    trainer: "Aditya Raj",
    status: "ongoing", // Try changing to "completed" to test color
    startDate: "2025-07-01",
    endDate: "2025-08-15"
  };

  return (
    <div>
      <CohortDetails cohort={sampleCohort} />
    </div>
  );
}

export default App;
