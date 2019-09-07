import React, { Fragment } from 'react';
import { Icon, Segment } from 'semantic-ui-react';
import GlobasStyles from '../../theme/GlobalStyles';
import Navbar from './Navbar';
import { Link } from 'react-router-dom';
import { Header, Content } from './styles';

const Layout: React.FC = ({ children }) => {
  return (
    <Fragment>
      <GlobasStyles />
      <Header>
        <Link to="/">
          <Segment raised circular compact>
            <h2>
              <Icon color="blue" name="book" size="small" />
              Books
            </h2>
          </Segment>
        </Link>
      </Header>
      <Content>{children}</Content>
      <Navbar />
    </Fragment>
  );
};

export default Layout;
