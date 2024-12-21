import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import FormsyReactComponent from './FormsyReactComponent';

describe('<FormsyReactComponent />', () => {
  test('it should mount', () => {
    render(<FormsyReactComponent />);

    const formsyReactComponent = screen.getByTestId('FormsyReactComponent');

    expect(formsyReactComponent).toBeInTheDocument();
  });
});