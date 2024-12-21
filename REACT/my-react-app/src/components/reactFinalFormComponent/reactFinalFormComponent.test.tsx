import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import reactFinalFormComponent from './reactFinalFormComponent';

describe('<reactFinalFormComponent />', () => {
  test('it should mount', () => {
    render(<reactFinalFormComponent />);

    const reactFinalFormComponent = screen.getByTestId('reactFinalFormComponent');

    expect(reactFinalFormComponent).toBeInTheDocument();
  });
});