import { createGlobalStyle } from 'styled-components';

const GlobasStyles = createGlobalStyle`
  /* width */
  ::-webkit-scrollbar {
    width: 10px;
  }

  /* Track */
  ::-webkit-scrollbar-track {
    border-radius: 10px;
  }

  /* Handle */
  ::-webkit-scrollbar-thumb {
    background: #CACBCE;
    border-radius: 10px;

  }

  /* Handle on hover */
  ::-webkit-scrollbar-thumb:hover {
    background: #ddd;
  }
  body{
    background-color:#ffc5a1 !important;
  }
`;

export default GlobasStyles;
