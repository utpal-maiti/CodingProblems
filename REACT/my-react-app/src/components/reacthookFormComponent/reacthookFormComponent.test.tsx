import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import reacthookFormComponent from './reacthookFormComponent';

describe('<reacthookFormComponent />', () => {
  test('it should mount', () => {
    render(<reacthookFormComponent />);

    const reacthookFormComponent = screen.getByTestId('reacthookFormComponent');

    expect(reacthookFormComponent).toBeInTheDocument();
  });
});