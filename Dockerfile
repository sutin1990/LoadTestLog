# Use the official Grafana image as base
FROM grafana/grafana:latest

# Example: Install a custom Grafana plugin
# RUN grafana-cli plugins install <plugin-id>

# Example: Copy a custom configuration file
# COPY custom.ini /etc/grafana/grafana.ini

# Expose port (default for Grafana)
EXPOSE 3000

# You can add additional customizations if needed

# Start Grafana when container launches
CMD [ "/run.sh" ]
