import React from 'react';
import styled from 'styled-components';
import { Button } from 'semantic-ui-react';
import { RouteComponentProps, withRouter } from 'react-router';

const Box = styled.nav`
  @media screen and (min-width: 800px) {
    width: 50%;
    left: 25%;
  }

  width: 100%;
  position: fixed;
  margin: 0 auto;
  bottom: 0%;
  height: 90px;
  background: #fcf9ea;
  display: flex;
  justify-content: center;
  align-items: center;
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;

  box-shadow: 0 0 10px 0px rgba(3, 3, 3, 0.5);
`;

const StyledButton = styled(Button)`
  :hover {
    transform: scale(1.1) !important;
  }
  :active {
    transform: scale(0.9) !important;
  }
  transition: 0.2s !important;
`;

const Navbar: React.FC<RouteComponentProps> = ({ history }) => {
  console.log(history);

  return (
    <Box>
      <StyledButton
        icon="plus"
        size="massive"
        circular
        onClick={() => history.push('/books/new')}
      />
    </Box>
  );
};

export default withRouter(Navbar);
