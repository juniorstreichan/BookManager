import React, { useState, useEffect } from 'react';
import { RouteComponentProps } from 'react-router';
import Book from '../models/Book';
import BookCard from '../components/BookCard';
import { Card } from 'semantic-ui-react';

const Books: React.FC<RouteComponentProps> = ({ history }) => {
  const [books, setBooks] = useState<Book[]>([]);
  const [isLoadding, setIsLoadding] = useState(false);
  const [error, setError] = useState<Error | null>(null);

  useEffect(() => {
    (async () => {
      try {
        setIsLoadding(true);
        const response = await fetch(`${process.env.REACT_APP_API_URL}/api/books`);
        const data = await response.json();
        setBooks(data);
      } catch (e) {
        setError(e);
      } finally {
        setIsLoadding(false);
      }
    })();
  }, []);

  return (
    <div>
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
