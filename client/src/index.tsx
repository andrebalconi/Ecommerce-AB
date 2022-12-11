import React from 'react'
import ReactDOM from 'react-dom/client'
import './app/layout/styles.css'
import App from './app/layout/App'
import reportWebVitals from './reportWebVitals'
import { BrowserRouter, Router } from 'react-router-dom'
import { StoreProvider } from './app/context/StoreContext'
import { createBrowserHistory } from 'history'
import {} from './'

export const history = createBrowserHistory()

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement)
root.render(
  <React.StrictMode>
    <BrowserRouter>
      <StoreProvider>
        <App />
      </StoreProvider>
    </BrowserRouter>
  </React.StrictMode>,
)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals()
