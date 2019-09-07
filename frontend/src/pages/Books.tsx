import React, { useState, useEffect, useContext } from 'react';
import { RouteComponentProps } from 'react-router';
import Book from '../models/Book';
import BookCard from '../components/BookCard';
import { Card, Loader } from 'semantic-ui-react';
import AppContext from '../context/AppContext';
import { selectGenre, selectAuthor, selectPublishingCompany } from '../context/selectors';

const Books: React.FC<RouteComponentProps> = ({ history }) => {
  const [books, setBooks] = useState<Book[]>([]);
  const [isLoadding, setIsLoadding] = useState(false);
  const [error, setError] = useState<Error | null>(null);
  const { state, isAllfetched } = useContext(AppContext);

  useEffect(() => {
    if (isAllfetched) {
      (async () => {
        try {
          setIsLoadding(true);
          const response = await fetch(`${process.env.REACT_APP_API_URL}/api/books`);
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
  }, [isAllfetched]);

  return (
    <div>
      {isLoadding && <Loader />}
      {!isLoadding && !error && (
        <Card.Group centered>
          {books.map(book => (
            <BookCard
              key={`BookCard-${book.id}`}
              book={book}
              onClickEdit={() => history.push(`/books/${book.id}`)}
              onCickDelete={() => history.push(`/books/${book.id}`)}
            />
          ))}
        </Card.Group>
      )}
    </div>
  );
};

export default Books;
