import React, { useState } from 'react';
import './App.css';

function App() {
    const [count, setCount] = useState(0);
    const [message, setMessage] = useState('');
    const [welcomeMsg, setWelcomeMsg] = useState('');
    const [clickedMsg, setClickedMsg] = useState('');
    const [rupees, setRupees] = useState('');
    const [euro, setEuro] = useState(null);

    // Multiple actions on Increment
    const handleIncrement = () => {
        setCount(prev => prev + 1);
        sayHello();
    };

    const sayHello = () => {
        setMessage('Hello! Counter incremented.');
    };

    const handleDecrement = () => {
        setCount(prev => prev - 1);
        setMessage('Counter decremented.');
    };

    const sayWelcome = (msg) => {
        setWelcomeMsg(msg);
    };

    const handleSyntheticClick = () => {
        setClickedMsg('I was clicked');
    };

    const handleConvert = (e) => {
        e.preventDefault();
        const euroRate = 0.011; // Example conversion rate
        setEuro((parseFloat(rupees) * euroRate).toFixed(2));
    };

    return (
        <div style={{ padding: '20px', fontFamily: 'Arial' }}>
            <h1>🌟 Event Examples App</h1>

            {/* Counter Example */}
            <h2>Counter</h2>
            <p>Count: {count}</p>
            <button onClick={handleIncrement}>Increment</button>{' '}
            <button onClick={handleDecrement}>Decrement</button>
            <p>{message}</p>

            <hr />

            {/* Say Welcome Example */}
            <h2>Say Welcome</h2>
            <button onClick={() => sayWelcome('Welcome to React Events!')}>Say Welcome</button>
            <p>{welcomeMsg}</p>

            <hr />

            {/* Synthetic Event */}
            <h2>Synthetic Event</h2>
            <button onClick={handleSyntheticClick}>Click Me</button>
            <p>{clickedMsg}</p>

            <hr />

            {/* Currency Converter */}
            <h2>Currency Converter</h2>
            <form onSubmit={handleConvert}>
                <label>INR: </label>
                <input
                    type="number"
                    value={rupees}
                    onChange={(e) => setRupees(e.target.value)}
                    required
                />
                <button type="submit">Convert</button>
            </form>
            {euro !== null && (
                <p>💱 Euro Equivalent: <strong>€{euro}</strong></p>
            )}
        </div>
    );
}

export default App;
