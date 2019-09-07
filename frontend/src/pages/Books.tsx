import React, { useState, useEffect, useContext } from 'react';
import { RouteComponentProps } from 'react-router';
import Book from '../models/Book';
import BookCard from '../components/BookCard';
import { Card, Loader, Message, Button, Divider } from 'semantic-ui-react';
import AppContext from '../context/AppContext';
import { selectGenre, selectAuthor, selectPublishingCompany } from '../context/selectors';
import axios from 'axios';

const Books: React.FC<RouteComponentProps> = ({ history, location }) => {
  const [books, setBooks] = useState<Book[]>([]);
  const [isLoadding, setIsLoadding] = useState(false);
  const [error, setError] = useState<Error | null>(null);
  const { state, isAllfetched } = useContext(AppContext);

  const deleteBook = async (book: Book) => {
    try {
      setIsLoadding(true);
      const response = await axios.delete(`${process.env.REACT_APP_API_URL}/api/books/${book.id}`);
      console.log(response);

      if (response.status === 200) {
        setBooks(books.filter(b => b.id !== book.id));
      }
    } catch (e) {
    } finally {
      setIsLoadding(false);
    }
  };

  useEffect(() => {
    console.log(location.search);

    if (isAllfetched) {
      (async () => {
        try {
          setIsLoadding(true);
          const url = `${process.env.REACT_APP_API_URL}${
            !location.search ? '/api/books' : '/api/books/q' + location.search
          }`;
          const response = await fetch(url);
          const data: Book[] = await response.json();
          setBooks(
            data.map(b => {
              b.genre = selectGenre(b.genreId, state.genres);
              b.author = selectAuthor(b.authorId, state.authors);
              b.publishingCompany = selectPublishingCompany(
                b.publishingCompanyId,
                state.publishingCompanies,
              );
              return b;
            }),
          );
        } catch (e) {
          setError(e);
        } finally {
          setIsLoadding(false);
        }
      })();
    }
  }, [isAllfetched, location.search]);

  return (
    <div>
      {isLoadding && <Loader />}
      {!isLoadding && !location.search && !error && books.length === 0 && (
        <Message positive>
          Ops! <br />
          Você aonda não tem livros cadastrados
          <Divider />
          <Button positive onClick={() => history.push('/books/new')}>
            Cadastrar
          </Button>
        </Message>
      )}
      {!isLoadding && location.search && !error && books.length === 0 && (
        <Message>
          Sua busca não teve resultados
          <Divider />
          <Button onClick={() => history.push('/')}>Voltar</Button>
        </Message>
      )}
      {!isLoadding && !error && (
        <Card.Group centered>
          {books.map(book => (
            <BookCard
              key={`BookCard-${book.id}`}
              book={book}
              onClickEdit={() => history.push({ pathname: `/books/${book.id}`, state: { book } })}
              onCickDelete={() => deleteBook(book)}
            />
          ))}
        </Card.Group>
      )}
    </div>
  );
};

export default Books;
