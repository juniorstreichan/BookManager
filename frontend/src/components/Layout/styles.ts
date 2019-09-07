import { Button } from 'semantic-ui-react';
import styled from 'styled-components';

export const NavbarBox = styled.nav`
  @media screen and (min-width: 800px) {
    width: 40%;
    left: 30%;
  }

  width: 100%;
  position: fixed;
  margin: 0 auto;
  bottom: 0%;
  height: 90px;
  background: #fff;
  display: flex;
  justify-content: center;
  align-items: center;
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;

  box-shadow: 0 0 10px 0px rgba(3, 3, 3, 0.5);
`;

export const StyledButton = styled(Button)`
  :hover {
    transform: scale(1.1) translateY(-5px) !important;
  }
  :active {
    transform: scale(0.9) !important;
  }
  transition: 0.2s !important;
`;

export const Content = styled.main`
  padding-top: 10px;
  padding-bottom: 100px;
  width: 80%;
  height: 100%;
  margin: 0 auto;
  display: flex;
  justify-content: center;
`;

export const Header = styled.header`
  padding: 10px 0;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: baseline;
  border-bottom: #fff dashed 1px;
`;
