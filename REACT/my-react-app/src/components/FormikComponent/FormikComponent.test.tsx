import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import FormikComponent from './FormikComponent';

describe('<FormikComponent />', () => {
  test('it should mount', () => {
    render(<FormikComponent />);

    const formikComponent = screen.getByTestId('FormikComponent');

    expect(formikComponent).toBeInTheDocument();
  });
});