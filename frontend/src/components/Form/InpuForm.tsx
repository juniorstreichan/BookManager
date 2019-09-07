import { ErrorMessage, Field, FieldProps } from 'formik';
import React from 'react';
import { Input, InputProps, Header } from 'semantic-ui-react';

interface Props {
  name: string;
  label?: string;
}

export const CustomError: React.FC<{ name: string }> = ({ name = '' }) => {
  return (
    <ErrorMessage name={name}>
      {msg =>
        msg && (
          <span
            data-testid="error-msg"
            style={{
              margin: 0,
              padding: 0,
              color: '#900',
              fontSize: '0.9rem',
              textAlign: 'left',
            }}
          >
            {`* ${msg}`}
          </span>
        )
      }
    </ErrorMessage>
  );
};

type InputFormProps = InputProps & Props;

const InputForm: React.FC<InputFormProps> = ({ name, label, ...rest }) => {
  return (
    <div style={{ textAlign: 'left', marginBottom: '15px' }}>
      {label && (
        <div>
          {/*
           // @ts-ignore */}
          <Header as="label" size={rest.size !== 'big' ? rest.size : ''} htmlFor={name}>
            {label}
          </Header>
          <br />
        </div>
      )}
      <Field
        id={name}
        name={name}
        render={({ field }: FieldProps) => <Input {...field} {...rest} />}
      />
      <CustomError name={name} />
    </div>
  );
};

export default InputForm;
