import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './components/App/App';
import Viewer from './components/Viewer/Viewer';
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
    <React.StrictMode>

        <Viewer className={'viewer'} tileSources={'https://raw.githubusercontent.com/openseadragon/openseadragon/master/test/data/testpattern.dzi'} />

        <Viewer style={{ width: '800px', height: '600px', display: 'inline-block' }} tileSources={[
            'https://openseadragon.github.io/example-images/highsmith/highsmith.dzi',
            'https://openseadragon.github.io/example-images/highsmith/highsmith.dzi',
            'https://openseadragon.github.io/example-images/highsmith/highsmith.dzi',
            'https://openseadragon.github.io/example-images/highsmith/highsmith.dzi'
        ]} />

  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
