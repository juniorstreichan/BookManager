import React, { Fragment } from 'react';
import { Icon, Segment } from 'semantic-ui-react';
import styled from 'styled-components';
import GlobasStyles from '../../theme/GlobalStyles';
import Navbar from './Navbar';
import { Link } from 'react-router-dom';

const Content = styled.main`
  padding-bottom: 100px;
  width: 80%;
  height: 100%;
  margin: 0 auto;
  display: flex;
  justify-content: center;
`;

const Header = styled.header`
  padding: 10px 0;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: baseline;
  border-bottom: #ffc5a1 dashed 1px;
`;

const Layout: React.FC = ({ children }) => {
  return (
    <Fragment>
      <GlobasStyles />
      <Header>
        <Link to="/">
          <Segment stacked>
            <h1>
              <Icon name="book" size="big" color="grey" />
              Books
            </h1>
          </Segment>
        </Link>
      </Header>
      <Content>{children}</Content>
      <Navbar />
    </Fragment>
  );
};

export default Layout;
