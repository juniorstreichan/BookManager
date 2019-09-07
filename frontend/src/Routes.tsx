import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';
import Books from './pages/Books';
import FormBook from './pages/FormBook';

const Routes: React.FC = () => {
  return (
    <Switch>
      <Route path="/" exact component={Books} />
      <Route path="/books/new" exact component={FormBook} />
      <Route path="/books/:id" exact component={FormBook} />
      <Route path="*" render={() => <Redirect to="/" />} />
    </Switch>
  );
};

export default Routes;
