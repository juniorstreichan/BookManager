import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';

const Routes: React.FC = () => {
  return (
    <Switch>
      <Route path="/" exact component={() => <div>HOME</div>} />
      <Route path="/books/new" exact component={() => <div>BOOK</div>} />
      <Route path="/books/:id" exact component={() => <div>BOOK EDIT</div>} />
      <Route path="*" render={() => <Redirect to="/" />} />
    </Switch>
  );
};

export default Routes;
