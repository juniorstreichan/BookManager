import React, { useState, useCallback, useEffect } from 'react';
import Layout from './components/Layout';
import Routes from './Routes';
import { AppState } from './context/types';
import AppContext, { defaultAppContext } from './context/AppContext';

const App: React.FC = () => {
  const [store, setStore] = useState<AppState>(defaultAppContext.state);

  useEffect(() => {
    if (store.authors.length <= 0) {
      (async () => {
        try {
          const response = await fetch(`${process.env.REACT_APP_API_URL}/api/authors`);
          const data = await response.json();
          setStore(state => ({ ...state, authors: data }));
        } catch (error) {}
      })();
    }
  }, [store.authors.length]);

  useEffect(() => {
    if (store.genres.length <= 0) {
      (async () => {
        try {
          const response = await fetch(`${process.env.REACT_APP_API_URL}/api/genres`);
          const data = await response.json();
          setStore(state => ({ ...state, genres: data }));
        } catch (error) {}
      })();
    }
  }, [store.genres.length]);

  useEffect(() => {
    if (store.publishingCompanies.length <= 0) {
      (async () => {
        try {
          const response = await fetch(`${process.env.REACT_APP_API_URL}/api/publishers`);
          const data = await response.json();
          setStore(state => ({ ...state, publishingCompanies: data }));
        } catch (error) {}
      })();
    }
  }, [store.publishingCompanies.length]);

  const isAllfetched =
    store.publishingCompanies.length > 0 && store.authors.length > 0 && store.genres.length > 0;

  return (
    <AppContext.Provider value={{ state: store, isAllfetched }}>
      <Layout>
        <Routes />
      </Layout>
    </AppContext.Provider>
  );
};

export default App;
