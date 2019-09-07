import React from 'react';
import { RouteComponentProps, withRouter } from 'react-router';
import { NavbarBox, StyledButton } from './styles';

const Navbar: React.FC<RouteComponentProps> = ({ history }) => {
  // console.log(history);

  return (
    <NavbarBox>
      <StyledButton
        icon="plus"
        size="massive"
        circular
        onClick={() => history.push('/books/new')}
      />
    </NavbarBox>
  );
};

export default withRouter(Navbar);
