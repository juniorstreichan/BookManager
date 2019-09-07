import React, { useContext } from 'react';
import { Dropdown } from 'semantic-ui-react';
import AppContext from '../../context/AppContext';

const DropdownGenres: React.FC<{
  onChange: (genreId: number) => void;
  value?: number | null;
}> = ({ onChange, value }) => {
  const { state } = useContext(AppContext);
  return (
    <Dropdown
      fluid
      placeholder="Selecione um Gênero"
      options={state.genres.map(a => ({ key: a.id, value: a.id, text: a.description }))}
      onChange={(e, { value }) => onChange((value as number) || 0)}
      selection
      search
      //@ts-ignore
      value={value || null}
    />
  );
};

export default DropdownGenres;
