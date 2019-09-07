import React, { useMemo, useEffect, useState } from 'react';
import { RouteComponentProps, withRouter } from 'react-router';
import { NavbarBox, StyledButton } from './styles';
import { Popup } from 'semantic-ui-react';

function scrollToTop() {
  const c = document.documentElement.scrollTop || document.body.scrollTop;
  if (c > 0) {
    window.requestAnimationFrame(scrollToTop);
    window.scrollTo(0, c - c / 8);
  }
}

const Navbar: React.FC<RouteComponentProps> = ({ history }) => {
  const { location } = history;
  const [showButton, setShowButton] = useState(false);

  useEffect(() => {
    function scrollTopEvent() {
      const { pageYOffset } = window;

      setShowButton(pageYOffset > 300);
    }
    window.addEventListener('scroll', scrollTopEvent);

    return () => {
      window.removeEventListener('scroll', scrollTopEvent);
    };
  }, []);

  const CenterButton = useMemo(() => {
    if (location.pathname === '/') {
      return (
        <Popup
          position="top center"
          content="Adicionar novo Livro"
          trigger={
            <div>
              <StyledButton
                icon="plus"
                size="massive"
                circular
                onClick={() => history.push('/books/new')}
              />
            </div>
          }
        />
      );
    }
    if (location.pathname.startsWith('/books')) {
      return (
        <Popup
          position="top center"
          content="Lista de Livros"
          trigger={
            <div>
              <StyledButton icon="list" size="massive" circular onClick={() => history.push('/')} />
            </div>
          }
        />
      );
    }
  }, [location.pathname]);

  return (
    <NavbarBox>
      <StyledButton icon="search" circular />
      {CenterButton}
      <StyledButton disabled={!showButton} onClick={scrollToTop} icon="angle up" circular />
    </NavbarBox>
  );
};

export default withRouter(Navbar);
