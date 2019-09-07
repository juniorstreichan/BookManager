import React, { Fragment } from 'react';
import { Icon, Segment, Image } from 'semantic-ui-react';
import GlobasStyles from '../../theme/GlobalStyles';
import Navbar from './Navbar';
import { Link } from 'react-router-dom';
import { Header, Content } from './styles';
import logo from '../../assets/img/logo512.png';
const Layout: React.FC = ({ children }) => {
  return (
    <Fragment>
      <GlobasStyles />
      <Header>
        <Link to="/">
          <Segment raised circular compact>
            <div style={{ display: 'flex', flexDirection: 'row', alignItems: 'center' }}>
              <h2>Books</h2>
              <Image src={logo} alt="Book" style={{ maxWidth: '50px' }} />
            </div>
          </Segment>
        </Link>
      </Header>
      <Content>{children}</Content>
      <Navbar />
    </Fragment>
  );
};

export default Layout;
