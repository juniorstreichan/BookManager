import React, { useMemo, useEffect, useState } from 'react';
import { RouteComponentProps, withRouter } from 'react-router';
import { NavbarBox, StyledButton } from './styles';
import { Popup, Input, Header, Button } from 'semantic-ui-react';
import DropdownAuthors from '../Dropdowns/DropdownAuthors';

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
  const [author, setAuthor] = useState(0);
  const [title, setTitle] = useState('');

  const handleSearch = () => {
    let query = '?';
    if (title !== '') {
      query += `title=${title}`;
    }

    if (author > 0) {
      query += `&author=${author}`;
    }
    setAuthor(0);
    setTitle('');
    history.push(`/${query}`);
  };

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
                color="blue"
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
              <StyledButton
                color="blue"
                icon="list"
                size="massive"
                circular
                onClick={() => history.push('/')}
              />
            </div>
          }
        />
      );
    }
  }, [location.pathname]);

  return (
    <NavbarBox>
      <Popup
        on="click"
        position="top center"
        trigger={
          <div>
            <StyledButton color="blue" icon="search" circular />
          </div>
        }
      >
        <Header>Buscar</Header>
        <Input
          name="q"
          value={title}
          onChange={(e, { value }) => setTitle(value)}
          placeholder="Título do livro"
        />
        <DropdownAuthors value={author} onChange={id => setAuthor(id)} />
        <Button
          onClick={() => handleSearch()}
          disabled={author === 0 && title === ''}
          fluid
          icon="search"
        />
      </Popup>
      {CenterButton}
      <StyledButton
        color="blue"
        disabled={!showButton}
        onClick={scrollToTop}
        icon="angle up"
        circular
      />
    </NavbarBox>
  );
};

export default withRouter(Navbar);
