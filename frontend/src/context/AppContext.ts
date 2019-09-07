import React from 'react';
import { AppContextType } from './types';

export const defaultAppContext: AppContextType = {
  state: {
    authors: [],
    genres: [],
    publishingCompanies: [],
  },
  isAllfetched: false,
};

const AppContext = React.createContext<AppContextType>(defaultAppContext);

export default AppContext;
